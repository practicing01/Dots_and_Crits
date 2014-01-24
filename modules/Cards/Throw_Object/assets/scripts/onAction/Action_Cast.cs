function Module_Card_Throw_Object::Action_Cast(%this,%Player_Information,
%Bool_Type_Of_Object,
%Player_Game_Connection_Or_Object_Module_ID,
%Object_Game_Connection,
%Object_Index,
%Vector_2D_Position)
{

%Target_Player=0;

if (!%Bool_Type_Of_Object)//Player
{

for (%x=0;%x<Module_Player_Class.Simset_Player_Data.getCount();%x++)
{

%Player_Object=Module_Player_Class.Simset_Player_Data.getObject(%x);

if (%Player_Object.Game_Connection_Handle==%Player_Game_Connection_Or_Object_Module_ID)
{

%Target_Player=%Player_Object;

break;

}

}

if (%Target_Player==0){return;}

%Target_Player.Player_Sprite_Data.Sprite.setLinearDamping(0);

%Target_Player.Player_Sprite_Data.Sprite.moveTo(%Vector_2D_Position,100,true,false);

}
else
{

/*Find object to grab*/
%Scene_Object=0;

for (%x=0;%x<%Player_Game_Connection_Or_Object_Module_ID.Simset_Objects.getCount();%x++)
{

%Object=%Player_Game_Connection_Or_Object_Module_ID.Simset_Objects.getObject(%x);

if ((%Object.Game_Connection_Handle==%Object_Game_Connection)&&(%Object.Object_Index==%Object_Index))
{

%Scene_Object=%Object;

break;

}

}

if (%Scene_Object==0){return;}

%Scene_Object.moveTo(%Vector_2D_Position,100,false,false);

}

}
