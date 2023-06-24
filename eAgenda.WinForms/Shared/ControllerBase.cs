using eAgenda.Domain.Shared;

namespace eAgenda.WinForms.Shared
{
    public abstract class ControllerBase
    {
        protected ControllerBase() {  }
               

        public abstract string GetRegisterType();
                
        public abstract string ToolTipAdd { get; }
        public abstract string ToolTipUpdate { get; }
        public abstract string ToolTipDelete { get; }

        public virtual bool AddEnable { get { return true; } }
        public virtual bool UpdateEnable { get { return true; } }
        public virtual bool DeleteEnable { get { return true; } }

        //-----------------------------------------------------------------

        public virtual string ToolTipFilter { get; }
        public virtual string ToolTipAddItem { get; }
        public virtual string ToolTipCheckItem { get; }

        public virtual bool FilterEnable { get { return false; } }
        public virtual bool lblFilterVisible { get { return false; } }
        public virtual bool AddItemEnable { get { return false; } }
        public virtual bool CheckItemEnable { get { return false; } }

        //-----------------------------------------------------------------
                
        public abstract UserControl GetList();

        public abstract void Add();
        public abstract void Update();
        public abstract void Delete();

        public virtual void Filter() { }
        public virtual void AddItem() { }
        public virtual void CheckItem() { }
    }
}
