public class ChallengeTableController : IController<ChallengeTableModel, ChallengeTableView>
{
    public IModel Model { get; set; }
    public IView View { get; set; }

    public ChallengeTableController(ChallengeTableModel model, ChallengeTableView view)
    {
        this.Model = model;
        this.View = view;

        SetView();
    }

    public void SetView()
    {
        View.SetTitle(Model.Title);
        View.SetContent(Model.GetHeaders(), Model.GetContentData());
    }
}
