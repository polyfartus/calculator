
// This file has been generated by the GUI designer. Do not modify.
namespace MathObjects.UI.Input
{
	public partial class InputWidget
	{
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Alignment alignment1;
		
		private global::Gtk.Entry entry1;
		
		private global::MathObjects.UI.Stack.StackButtonWidget stackbuttonwidget1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MathObjects.UI.Input.InputWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MathObjects.UI.Input.InputWidget";
			// Container child MathObjects.UI.Input.InputWidget.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.alignment1.BorderWidth = ((uint)(9));
			// Container child alignment1.Gtk.Container+ContainerChild
			this.entry1 = new global::Gtk.Entry ();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '•';
			this.alignment1.Add (this.entry1);
			this.hbox1.Add (this.alignment1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.alignment1]));
			w2.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.stackbuttonwidget1 = new global::MathObjects.UI.Stack.StackButtonWidget ();
			this.stackbuttonwidget1.Events = ((global::Gdk.EventMask)(256));
			this.stackbuttonwidget1.Name = "stackbuttonwidget1";
			this.hbox1.Add (this.stackbuttonwidget1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.stackbuttonwidget1]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}