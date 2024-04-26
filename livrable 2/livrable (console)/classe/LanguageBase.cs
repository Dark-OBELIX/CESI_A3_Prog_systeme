namespace classe
{
    public class LanguageBase
    {
        // Utilisez une variable privée pour stocker la valeur de la propriété
        private bool _cut_copy;
        public virtual bool cut_copy
        {
            get { return _cut_copy;  }
            set { _cut_copy = value; }
        }
        public virtual string set_lang() { return ""; }
        public virtual string choice_cut_copy() { return ""; }
        public virtual string validation_choice_cut(){ return "";}
        public virtual string validation_choice_copy(){return "";}
        public virtual string choice_stain_name() { return ""; }

    }
}
