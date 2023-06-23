using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Drawing;

public class CustomScrollBarRenderer : ScrollBarRenderer
{
    protected override void OnRenderArrowButton(ToolStripArrowRenderEventArgs e)
    {
        // Personaliza el aspecto visual del botón de flecha
        // Cambia los valores de los colores y el diseño según tus preferencias

        if (e.Item is ToolStripScrollBar.ScrollBarButton)
        {
            Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);
            ButtonState state = e.Item.Enabled ? ButtonState.Normal : ButtonState.Inactive;

            if (e.Item.Pressed)
            {
                state = ButtonState.Pushed;
            }
            else if (e.Item.Selected)
            {
                state = ButtonState.Hot;
            }

            if (e.Item.Owner is ToolStrip)
            {
                var toolStrip = (ToolStrip)e.Item.Owner;
                if (toolStrip.Orientation == Orientation.Vertical)
                {
                    using (var brush = new SolidBrush(Color.Gray)) // Cambia el color de fondo de la barra de desplazamiento
                    {
                        e.Graphics.FillRectangle(brush, rect);
                    }
                }
            }

            if (VisualStyleRenderer.IsSupported)
            {
                var renderer = new VisualStyleRenderer(VisualStyleElement.ScrollBar.ArrowButton.UpNormal);
                renderer.DrawBackground(e.Graphics, rect, state);
            }
        }
    }
}
