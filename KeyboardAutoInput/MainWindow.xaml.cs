using System.Windows;
using System.Windows.Input;
namespace KeyboardAutoInput
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();
        private void CClose(object sender, RoutedEventArgs e) => Close();
        private void Drag(object sender, MouseButtonEventArgs e) => DragMove();

        private void CInput(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
            foreach (var c in Tb.Text)
            {
                switch (c)
                {
                    case ' ': Type(Key.Space); break;
                    case ',': Type(Key.OemComma); break;
                    case '.': Type(Key.OemPeriod); break;
                    case '-': Type(Key.OemMinus); break;
                    case '\n': Type(Key.Return); break;
                    case ';': Type(Key.Oem1); break;
                    case ':': ShiftType(Key.Oem1); break;
                    case '?': ShiftType(Key.Oem2); break;
                    case '\'': Type(Key.Oem7); break;
                    case '"': ShiftType(Key.Oem7); break;
                    case '!': ShiftType(Key.D1); break;

                    case '1': Type(Key.D1); break;
                    case '2': Type(Key.D2); break;
                    case '3': Type(Key.D3); break;
                    case '4': Type(Key.D4); break;
                    case '5': Type(Key.D5); break;
                    case '6': Type(Key.D6); break;
                    case '7': Type(Key.D7); break;
                    case '8': Type(Key.D8); break;
                    case '9': Type(Key.D9); break;
                    case '0': Type(Key.D0); break;

                    case 'q': Type(Key.Q); break;
                    case 'w': Type(Key.W); break;
                    case 'e': Type(Key.E); break;
                    case 'r': Type(Key.R); break;
                    case 't': Type(Key.T); break;
                    case 'y': Type(Key.Y); break;
                    case 'u': Type(Key.U); break;
                    case 'i': Type(Key.I); break;
                    case 'o': Type(Key.O); break;
                    case 'p': Type(Key.P); break;
                    case 'a': Type(Key.A); break;
                    case 's': Type(Key.S); break;
                    case 'd': Type(Key.D); break;
                    case 'f': Type(Key.F); break;
                    case 'g': Type(Key.G); break;
                    case 'h': Type(Key.H); break;
                    case 'j': Type(Key.J); break;
                    case 'k': Type(Key.K); break;
                    case 'l': Type(Key.L); break;
                    case 'z': Type(Key.Z); break;
                    case 'x': Type(Key.X); break;
                    case 'c': Type(Key.C); break;
                    case 'v': Type(Key.V); break;
                    case 'b': Type(Key.B); break;
                    case 'n': Type(Key.N); break;
                    case 'm': Type(Key.M); break;

                    case 'Q': ShiftType(Key.Q); break;
                    case 'W': ShiftType(Key.W); break;
                    case 'E': ShiftType(Key.E); break;
                    case 'R': ShiftType(Key.R); break;
                    case 'T': ShiftType(Key.T); break;
                    case 'Y': ShiftType(Key.Y); break;
                    case 'U': ShiftType(Key.U); break;
                    case 'I': ShiftType(Key.I); break;
                    case 'O': ShiftType(Key.O); break;
                    case 'P': ShiftType(Key.P); break;
                    case 'A': ShiftType(Key.A); break;
                    case 'S': ShiftType(Key.S); break;
                    case 'D': ShiftType(Key.D); break;
                    case 'F': ShiftType(Key.F); break;
                    case 'G': ShiftType(Key.G); break;
                    case 'H': ShiftType(Key.H); break;
                    case 'J': ShiftType(Key.J); break;
                    case 'K': ShiftType(Key.K); break;
                    case 'L': ShiftType(Key.L); break;
                    case 'Z': ShiftType(Key.Z); break;
                    case 'X': ShiftType(Key.X); break;
                    case 'C': ShiftType(Key.C); break;
                    case 'V': ShiftType(Key.V); break;
                    case 'B': ShiftType(Key.B); break;
                    case 'N': ShiftType(Key.N); break;
                    case 'M': ShiftType(Key.M); break;
                    default: break;
                }
            }
        }

        private static void Type(Key key) => KeyboardToolkit.Keyboard.Type(key);

        private static void ShiftType(Key key)
        {
            KeyboardToolkit.Keyboard.Press(Key.LeftShift);
            KeyboardToolkit.Keyboard.Type(key);
            KeyboardToolkit.Keyboard.Release(Key.LeftShift);
        }
    }
}
