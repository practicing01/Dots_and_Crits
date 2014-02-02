function Class_Vector_Plant::Schedule_AI(%this)
{

if ($Bool_A_I_Token_Bearer)
{

/*********************************************************************/

%this.Module_ID_Parent.Vector_Plant_Count++;

if (%this.Plant_Parent!=-1)
{

if (%this.Plant_Parent.Int_Branch_Count>%this.Plant_Parent.Int_Max_Shape_Branches){return;}

commandToServer('Relay_Module_Function',Module_Card_Vector_Plant,"Action_Grow",
%this.Game_Connection_Handle,%this.Object_Index,-1,-1,0,%this.Module_ID_Parent.Vector_Plant_Count);

}
else
{

commandToServer('Relay_Module_Function',Module_Card_Vector_Plant,"Action_Grow",
%this.Game_Connection_Handle,%this.Object_Index,-1,-1,1,%this.Module_ID_Parent.Vector_Plant_Count);

}

%this.Int_Leaf_Count++;

if (%this.Int_Leaf_Count>=%this.Int_Max_Shape_Leaves){return;}

}

%this.Schedule_AI=schedule(500,0,"Class_Vector_Plant::Schedule_AI",%this);

}
