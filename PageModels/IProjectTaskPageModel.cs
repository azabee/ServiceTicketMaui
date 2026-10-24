using CommunityToolkit.Mvvm.Input;
using ServiceTicketMaui.Models;

namespace ServiceTicketMaui.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}