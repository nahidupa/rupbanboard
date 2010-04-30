using Rupban.Core;

namespace Rupban.LoginModule.Presenters
{
    public interface IColumnPresenter:ITemplateCelHolderPresenter
    {
        TemplateColumn TemplateColumn { get; set; }
    }
}
