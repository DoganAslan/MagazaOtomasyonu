using System.Drawing;
using System.Windows.Forms;

namespace MagazaOtomasyonu.Helpers
{
    public static class UiTheme
    {
        public static readonly Color Background = ColorTranslator.FromHtml("#F5F7FA");
        public static readonly Color Surface = ColorTranslator.FromHtml("#FFFFFF");
        public static readonly Color Primary = ColorTranslator.FromHtml("#2563EB");
        public static readonly Color PrimaryHover = ColorTranslator.FromHtml("#1D4ED8");
        public static readonly Color PrimarySoft = ColorTranslator.FromHtml("#EFF6FF");
        public static readonly Color TextPrimary = ColorTranslator.FromHtml("#111827");
        public static readonly Color TextSecondary = ColorTranslator.FromHtml("#6B7280");
        public static readonly Color Border = ColorTranslator.FromHtml("#E5E7EB");
        public static readonly Color Danger = ColorTranslator.FromHtml("#DC2626");
        public static readonly Color DangerHover = ColorTranslator.FromHtml("#B91C1C");
        public static readonly Color DangerSoft = ColorTranslator.FromHtml("#FEF2F2");
        public static readonly Color Success = ColorTranslator.FromHtml("#16A34A");
        public static readonly Color SuccessSoft = ColorTranslator.FromHtml("#F0FDF4");
        public static readonly Color LightSelection = ColorTranslator.FromHtml("#DBEAFE");

        private static readonly Color Secondary = ColorTranslator.FromHtml("#F3F4F6");
        private static readonly Color SecondaryHover = ColorTranslator.FromHtml("#E5E7EB");

        public static void Apply(Form form)
        {
            form.BackColor = Background;
            form.Font = new Font("Segoe UI", 10F);
            form.StartPosition = FormStartPosition.CenterScreen;

            foreach (Control control in form.Controls)
            {
                ApplyControl(control);
            }
        }

        public static void StyleButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.UseVisualStyleBackColor = false;
            button.Cursor = Cursors.Hand;
            button.Font = new Font("Segoe UI Semibold", 10F);
            button.Padding = new Padding(12, 0, 12, 0);
            button.MinimumSize = new Size(button.MinimumSize.Width, 38);
            if (button.Height < 38)
            {
                button.Height = 38;
            }

            string name = button.Name;

            if (name.Contains("Delete", StringComparison.OrdinalIgnoreCase) ||
                name.Contains("Remove", StringComparison.OrdinalIgnoreCase) ||
                name.Contains("Logout", StringComparison.OrdinalIgnoreCase))
            {
                button.BackColor = Danger;
                button.ForeColor = Color.White;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseOverBackColor = DangerHover;
                button.FlatAppearance.MouseDownBackColor = DangerHover;
            }
            else if (name.Contains("Update", StringComparison.OrdinalIgnoreCase))
            {
                button.BackColor = Surface;
                button.ForeColor = TextPrimary;
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.BorderColor = Border;
                button.FlatAppearance.MouseOverBackColor = Secondary;
                button.FlatAppearance.MouseDownBackColor = SecondaryHover;
            }
            else if (name.Contains("Clear", StringComparison.OrdinalIgnoreCase))
            {
                button.BackColor = Secondary;
                button.ForeColor = TextPrimary;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseOverBackColor = SecondaryHover;
                button.FlatAppearance.MouseDownBackColor = SecondaryHover;
            }
            else if (IsMenuButton(name))
            {
                button.BackColor = Surface;
                button.ForeColor = TextPrimary;
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.BorderColor = Border;
                button.FlatAppearance.MouseOverBackColor = LightSelection;
                button.FlatAppearance.MouseDownBackColor = LightSelection;
            }
            else
            {
                button.BackColor = Primary;
                button.ForeColor = Color.White;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseOverBackColor = PrimaryHover;
                button.FlatAppearance.MouseDownBackColor = PrimaryHover;
            }
        }

        public static void StyleTextBox(TextBox textBox)
        {
            textBox.BackColor = Surface;
            textBox.ForeColor = TextPrimary;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Font = new Font("Segoe UI", 10F);
            textBox.MinimumSize = new Size(textBox.MinimumSize.Width, 32);
            if (textBox.Height < 32)
            {
                textBox.Height = 32;
            }
        }

        public static void StyleComboBox(ComboBox comboBox)
        {
            comboBox.BackColor = Surface;
            comboBox.ForeColor = TextPrimary;
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.Font = new Font("Segoe UI", 10F);
            comboBox.MinimumSize = new Size(comboBox.MinimumSize.Width, 32);
            if (comboBox.Height < 32)
            {
                comboBox.Height = 32;
            }
        }

        public static void StylePanel(Panel panel)
        {
            panel.BackColor = Surface;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.TabStop = false;
        }

        public static void StyleGroupBox(GroupBox groupBox)
        {
            groupBox.BackColor = Surface;
            groupBox.ForeColor = TextPrimary;
            groupBox.Font = new Font("Segoe UI Semibold", 10F);
            groupBox.TabStop = false;
        }

        public static void StyleCheckBox(CheckBox checkBox)
        {
            checkBox.BackColor = Color.Transparent;
            checkBox.ForeColor = TextPrimary;
            checkBox.Font = new Font("Segoe UI", 10F);
        }

        public static void StyleDataGridView(DataGridView grid)
        {
            grid.BackgroundColor = Surface;
            grid.BorderStyle = BorderStyle.None;
            grid.RowHeadersVisible = false;
            grid.ColumnHeadersHeight = 40;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            grid.RowTemplate.Height = 38;
            grid.EnableHeadersVisualStyles = false;
            grid.GridColor = Border;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.DefaultCellStyle.BackColor = Surface;
            grid.DefaultCellStyle.ForeColor = TextPrimary;
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            grid.DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            grid.DefaultCellStyle.SelectionBackColor = LightSelection;
            grid.DefaultCellStyle.SelectionForeColor = TextPrimary;
            grid.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F9FAFB");
            grid.ColumnHeadersDefaultCellStyle.ForeColor = TextPrimary;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F);
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F9FAFB");
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = TextPrimary;
            grid.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F9FAFB");
        }

        public static void StyleLabel(Label label)
        {
            label.TabStop = false;
            label.ForeColor = label.Name.Contains("Description", StringComparison.OrdinalIgnoreCase) ||
                label.Name.Contains("Subtitle", StringComparison.OrdinalIgnoreCase)
                ? TextSecondary
                : TextPrimary;
        }

        private static void ApplyControl(Control control)
        {
            if (control is Panel panel)
            {
                StylePanel(panel);
            }
            else if (control is GroupBox groupBox)
            {
                StyleGroupBox(groupBox);
            }
            else if (control is CheckBox checkBox)
            {
                StyleCheckBox(checkBox);
            }
            else if (control is Button button)
            {
                StyleButton(button);
            }
            else if (control is TextBox textBox)
            {
                StyleTextBox(textBox);
            }
            else if (control is ComboBox comboBox)
            {
                StyleComboBox(comboBox);
            }
            else if (control is DataGridView grid)
            {
                StyleDataGridView(grid);
            }
            else if (control is Label label)
            {
                StyleLabel(label);
            }

            foreach (Control child in control.Controls)
            {
                ApplyControl(child);
            }
        }

        private static bool IsMenuButton(string name)
        {
            return name is "btnCategories" or "btnBrands" or "btnColors" or "btnSizes" or
                "btnProducts" or "btnStock" or "btnCustomers" or "btnSales" or
                "btnSalesHistory" or "btnUsers" or "btnReports";
        }
    }
}
