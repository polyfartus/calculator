
// This file has been generated by the GUI designer. Do not modify.
namespace MathObjects.UI.Widgets
{
	public partial class MathOperationsWidget
	{
		private global::Gtk.Table table1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MathObjects.UI.Widgets.MathOperationsWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MathObjects.UI.Widgets.MathOperationsWidget";
			// Container child MathObjects.UI.Widgets.MathOperationsWidget.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.Add (this.table1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}