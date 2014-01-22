function Module_Card_Distance_Joint::Action_Cast(%this,%Player_Information,
%Bool_Type_Of_Object,
%Player_Game_Connection_Or_Object_Module_ID,
%Object_Game_Connection,
%Object_Index,
%Bool_Type_Of_Object_0,
%Player_Game_Connection_Or_Object_Module_ID_0,
%Object_Game_Connection_0,
%Object_Index_0)
{

%Target_Player=0;//Used if player picked.
%Scene_Object=0;//Used if object picked.
%Target_Player_0=0;//Used if 2nd player picked.
%Scene_Object_0=0;//Used if 2nd object picked.

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

}
else
{

/*Find object to grab*/

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

}

/**************************************************************************************************************/

if (!%Bool_Type_Of_Object_0)//Player
{

for (%x=0;%x<Module_Player_Class.Simset_Player_Data.getCount();%x++)
{

%Player_Object=Module_Player_Class.Simset_Player_Data.getObject(%x);

if (%Player_Object.Game_Connection_Handle==%Player_Game_Connection_Or_Object_Module_ID_0)
{

%Target_Player_0=%Player_Object;

break;

}

}

if (%Target_Player_0==0){return;}

}
else
{

/*Find object to grab*/

for (%x=0;%x<%Player_Game_Connection_Or_Object_Module_ID_0.Simset_Objects.getCount();%x++)
{

%Object=%Player_Game_Connection_Or_Object_Module_ID_0.Simset_Objects.getObject(%x);

if ((%Object.Game_Connection_Handle==%Object_Game_Connection_0)&&(%Object.Object_Index==%Object_Index_0))
{

%Scene_Object_0=%Object;

break;

}

}

if (%Scene_Object_0==0){return;}

}

if (%Target_Player)
{

if (%Target_Player_0)
{

Scene_Dots_and_Crits.createDistanceJoint(%Target_Player.Composite_Sprite,%Target_Player_0.Composite_Sprite,
VectorDist(%Target_Player.Composite_Sprite.Position,%Target_Player_0.Composite_Sprite.Position),"0 0","0 0",1,0.5,false);

}
else//%Scene_Object_0
{

Scene_Dots_and_Crits.createDistanceJoint(%Target_Player.Composite_Sprite,%Scene_Object_0,
VectorDist(%Target_Player.Composite_Sprite.Position,%Scene_Object_0.Position),"0 0","0 0",1,0.5,false);

}

}
else//%Scene_Object
{

if (%Target_Player_0)
{

Scene_Dots_and_Crits.createDistanceJoint(%Scene_Object,%Target_Player_0.Composite_Sprite,
VectorDist(%Scene_Object.Position,%Target_Player_0.Composite_Sprite.Position),"0 0","0 0",1,0.5,false);

}
else//%Scene_Object_0
{

Scene_Dots_and_Crits.createDistanceJoint(%Scene_Object,%Scene_Object_0,
VectorDist(%Scene_Object.Position,%Scene_Object_0.Position),"0 0","0 0",1,0.5,false);

}

}

}