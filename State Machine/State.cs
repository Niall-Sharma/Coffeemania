    using Godot;
    using System;
    public partial class State : Node
    {
        public AnimationNodeStateMachinePlayback animationStateMachine; 
        public Player characterBody2D;
        public StateMachine fsm;
        public virtual void Enter(State previous = null) {}
        public virtual void Exit() {}
        public virtual void Process(double delta) {}
        public virtual void PhysicsProcess(double delta) {}
    }