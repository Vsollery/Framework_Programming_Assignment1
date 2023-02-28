﻿using Astronomy.Pages;

namespace Astronomy;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute("astronomicalbodydetails", typeof(AstronomicalBodyPage));
        Routing.RegisterRoute("informationdetails", typeof(Information));
    }
}
