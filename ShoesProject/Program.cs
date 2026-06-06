namespace ShoesProject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            bool exitProgram = false;

            while (!exitProgram)
            {
                using (var formlogin = new Form_Login())
                {
                    if (Form_Login.ShowDialog() == DialogResult.OK)
                    {
                        using (var Form_Products = new Form_Products(
                            Form_Login.CurrentUser,
                            Form_Login.IsGuest))
                        {
                            if (Form_Products.ShowDialog() == DialogResult.Cancel)
                            {
                                continue;
                            }
                            else
                            {
                                exitProgram = true;
                            }
                        }
                    }
                    else
                    {
                        exitProgram = true;
                    }
                }
            }
        }
    }
}