    public class State
    {
        public StateMachine fsm;
        public virtual void Enter(State previous = null) {}
        public virtual void Exit() {}
        public virtual void Process(float delta) {}
        public virtual void PhysicsProcess(float delta) {}
    }