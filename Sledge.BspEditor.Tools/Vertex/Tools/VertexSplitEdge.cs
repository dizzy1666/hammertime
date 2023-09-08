using Sledge.BspEditor.Documents;
using Sledge.Common.Shell.Commands;
using Sledge.Common.Shell.Context;
using Sledge.Common.Shell.Hotkeys;
using Sledge.Common.Translations;
using System.ComponentModel.Composition;
using System.Threading.Tasks;

namespace Sledge.BspEditor.Tools.Vertex.Tools
{
	[AutoTranslate]
	[Export(typeof(ICommand))]
	[CommandID("BspEditor:VertexSplitEdge")]
	[DefaultHotkey("Ctrl+F")]

	public class VertexSplitEdge : ICommand
	{
		public string Name { get; set; } = "Split edge";
		public string Details { get; set; } = "Split edge with selected vertices";

		public Task Invoke(IContext context, CommandParameters parameters)
		{
			VertexPointTool.SplitEdge();

			return Task.CompletedTask;
		}

		public bool IsInContext(IContext context)
		{
			return context.TryGet("ActiveDocument", out MapDocument _);
		}
	}
}
