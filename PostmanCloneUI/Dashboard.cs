using PostmanCloneLibrary;

namespace PostmanCloneUI;
public partial class Dashboard : Form
{
    private readonly IApiAccess api = new ApiAccess();
    public Dashboard()
    {
        InitializeComponent();
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

        try
        {
            tbResults.Text = await api.CallApiAsync(tbUrl.Text);
            systemStatus.Text = "Ready";

        }
        catch (Exception ex)
        {

            tbResults.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }
}
