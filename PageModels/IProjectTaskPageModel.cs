using AppCheckList1.Models;
using CommunityToolkit.Mvvm.Input;

namespace AppCheckList1.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}