﻿namespace FacadeExample
{
    public class VisualStudioFacade
    {
        TextEditor textEditor;
        Compiller compiller;
        CLR clr;

        public VisualStudioFacade(TextEditor te, Compiller compil, CLR c)
        {
            textEditor = te;
            compiller = compil;
            clr = c;
        }

        public void Start()
        {
            textEditor.CreateCode();
            textEditor.Save();
            compiller.Compile();
            clr.Execute();
        }

        public void Stop()
        {
            clr.Finish();
        }
    }
}
