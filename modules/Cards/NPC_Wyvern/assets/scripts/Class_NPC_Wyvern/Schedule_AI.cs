function Class_NPC_Wyvern::Schedule_AI(%this)
{

if ($Bool_A_I_Token_Bearer)
{

if (%this.Simset_Colliding_Objects.getCount())
{

%Collided_Object=%this.Simset_Colliding_Objects.getObject(0);//First in, first to die :D.

//0=Breath, 1=Move to.
%Random_Decision=getRandom(1,1);

if (%Random_Decision==0)
{

//send rpc

}
else
{

commandToServer('Relay_Module_Function',Module_Card_NPC_Wyvern,"Action_Move",%Collided_Object.Position,%this.Object_Index);

}

}

}

%this.Schedule_AI=schedule(2000,0,"Class_NPC_Wyvern::Schedule_AI",%this);

}
