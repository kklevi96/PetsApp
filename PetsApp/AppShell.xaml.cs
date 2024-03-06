﻿namespace PetsApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("petdetails", typeof(PetDetailsPage));
            Routing.RegisterRoute("newpet", typeof(NewPetPage));
        }
    }
}
