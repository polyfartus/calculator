
// This file has been generated by the GUI designer. Do not modify.
namespace MathObjects.UI
{
	public partial class ErrorWidget
	{
		private global::Gtk.Alignment alignment1;
		
		private global::Gtk.Label label1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MathObjects.UI.ErrorWidget
			global::Stetic.BinContainer.Attach (this);
			this.HeightRequest = 20;
			this.Name = "MathObjects.UI.ErrorWidget";
			// Container child MathObjects.UI.ErrorWidget.Gtk.Container+ContainerChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.label1 = new global::Gtk.Label ();
			this.label1.HeightRequest = 35;
			this.label1.Name = "label1";
			this.label1.Xpad = 10;
			this.label1.Xalign = 0F;
			this.alignment1.Add (this.label1);
			this.Add (this.alignment1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
