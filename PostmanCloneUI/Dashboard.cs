using PostmanCloneLibrary;

namespace PostmanCloneUI;
public partial class Dashboard : Form
{
    private readonly IApiAccess api = new ApiAccess();
    public Dashboard()
    {
        InitializeComponent();
        cbHttpMethod.SelectedItem = "GET";
    }

    private async void btCallApi_Click(object sender, EventArgs e)
    {
        tbResults.Text = "";
        systemStatus.Text = "Calling API...";

        if(api.IsValidUrl(tbUrl.Text) == false)
        {
            systemStatus.Text = "Invalid URL";
            return;
        }

        HttpAction action;

        if(Enum.TryParse(cbHttpMethod.SelectedItem!.ToString(), out action) == false)
        {
            systemStatus.Text = "Invalid HTTP verb";
            return;
        }

        try
        {
            tbResults.Text = await api.CallApiAsync(tbUrl.Text, tbBody.Text, action);
            tcCallData.SelectedTab = tabResults;
            tabResults.Focus();
            systemStatus.Text = "Ready";

        }
        catch (Exception ex)
        {

            tbResults.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }
}
