using Microsoft.AspNetCore.Mvc;

namespace RecursionTree.Models.Component
{
    public class NodeViewComponent1:ViewComponent
    {
 
        public async Task<IViewComponentResult> InvokeAsync(ICollection<Node> Nodes)
        {
            //...code
            return View( viewName: "_TreeComponent1", model: Nodes);
        }
    }
}
