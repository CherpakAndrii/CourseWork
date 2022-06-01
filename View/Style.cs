using System.Drawing;

namespace WinFormsApp1.View
{
    public static class Style
    {
        public static Color NextButtonColor = Color.RoyalBlue;
        public static Color ResetButtonColor = Color.DarkGray;
        public static Color NextButtonForeColor = Color.Azure;
        public static Color ResetButtonForeColor = Color.Black;
        
        public static readonly Font TextFieldFont = new System.Drawing.Font("Arial", 14F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        public static readonly Font TitleLabelFont = new System.Drawing.Font("Arial", 15.75F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        public static readonly Font InequalityFont = new System.Drawing.Font("Arial", 14F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        public static readonly Font NumerationLabelFont = new System.Drawing.Font("Arial", 14F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        
        public static Size ButtonSize = new System.Drawing.Size(80, 35);
        public static Size NumerationLabelSize = new System.Drawing.Size(28, 19);
        public static Size TitleLabelSize = new System.Drawing.Size(277, 20);
        public static Size TextFieldSize = new System.Drawing.Size(340, 30);
        public static Size InequalityLabelSize = new System.Drawing.Size(320, 20);
        public static Size NormalFormLabelSize = new System.Drawing.Size(160, 20);
        public static Size ArrowLabelSize = new System.Drawing.Size(50, 20);
        
    }
}