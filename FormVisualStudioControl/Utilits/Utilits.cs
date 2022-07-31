namespace FormVisualStudioControl;
static public class Utilits
{
    static public Tuple<bool, bool> SetTheme_VisualStudio(Control myControl, Color main, Color other, bool isLight, bool isDark,
        Action<Form, bool, bool, bool> setThemeModeForm, Action<Form, bool, bool, bool> setThemeModeFormAsync)
    {
        if (myControl is VisualStudioTabControl control)
        {
            if (isDark)
            {
                control.Theme = VisualStudioTabControlTheme.Dark;
            }
            else if(isLight)
            {
                control.Theme = VisualStudioTabControlTheme.Light;
            }
            return new(true, false);
        }
        return new(false, false);
    }
}
