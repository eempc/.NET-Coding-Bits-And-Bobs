        // To navigate to the listview address page - DO NOT DELETE
        public void InitialiseImageButton() {
            TapGestureRecognizer iconTap = new TapGestureRecognizer();
            iconTap.Tapped += (object sender, EventArgs e) => { DoSomething(); };
            Image ic = X:NameInXAML;
            ic.GestureRecognizers.Add(iconTap);
        }
        
