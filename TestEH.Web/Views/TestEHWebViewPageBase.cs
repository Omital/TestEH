using Abp.Web.Mvc.Views;

namespace TestEH.Web.Views
{
    public abstract class TestEHWebViewPageBase : TestEHWebViewPageBase<dynamic>
    {

    }

    public abstract class TestEHWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TestEHWebViewPageBase()
        {
            LocalizationSourceName = TestEHConsts.LocalizationSourceName;
        }
    }
}