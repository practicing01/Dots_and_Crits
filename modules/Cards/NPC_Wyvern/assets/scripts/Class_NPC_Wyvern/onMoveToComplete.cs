function Class_NPC_Wyvern::onMoveToComplete(%this)
{

%this.Bool_Is_Mobile=false;

%this.setLinearDamping(%this.Linear_Damping);

if (%this.Game_Connection_Handle==$GameConnection_Serverside_Connection)
{

commandToServer('Relay_Module_Function',%this.Module_ID_Parent,"Action_Position",
%this.Game_Connection_Handle,%this.Object_Index,%this.Position);

}

%this.Animation_Set("Hover");

}
