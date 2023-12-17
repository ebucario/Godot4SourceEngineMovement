//Virtual base class for all states.
using Godot;
using System;

namespace StateMachine;

// Reference to the state machine, to call its `transition_to()` method directly.
// That's one unorthodox detail of our state implementation, as it adds a dependency between the
// state and the state machine objects, but we found it to be most efficient for our needs.
// The state machine node will set it.
public partial class State : Node
{
	StateMachine.stateMachine ownerStateMachine;
	
	//Virtual function. Receives events from the `_unhandled_input()` callback.
	public void handle_input(InputEvent _event){

	}
	
	// Virtual function. Corresponds to the `_process()` callback.
	public void update(float delta){
		
	}


	// Virtual function. Corresponds to the `_physics_process()` callback.
	public void physics_update(double delta){
		
	}


	// Virtual function. Called by the state machine upon changing the active state. The `msg` parameter
	// is a dictionary with arbitrary data the state can use to initialize itself.
	public void enter(string _msg){
		//
	}


	// Virtual function. Called by the state machine before changing the active state. Use this function
	// to clean up the state.
	public void exit(){
		
	}
}
