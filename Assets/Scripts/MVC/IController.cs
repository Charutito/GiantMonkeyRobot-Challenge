public interface IController<M, V> where M : IModel where V : IView
{
    IModel Model { get; set; }
    IView View { get; set; }
}
