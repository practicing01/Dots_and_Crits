function Module_Card_Summon_Unit::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Vector_2D_Position,%Object_Index)
{

%Target_Player=0;

for (%x=0;%x<Module_Player_Class.Simset_Player_Data.getCount();%x++)
{

%Player_Object=Module_Player_Class.Simset_Player_Data.getObject(%x);

if (%Player_Object.Game_Connection_Handle==%Player_Sprite_Target_Game_Connection_Handle)
{

%Target_Player=%Player_Object;

break;

}

}

if (%Target_Player==0){return;}

//Use player info to play animations.

%Composite_Sprite_Summon_Unit=new CompositeSprite()
{

class="Class_Summon_Unit";
CollisionCallback="true";
SceneGroup=25;//25=npcs
SceneLayer=16;

Module_ID_Parent=%this;

Game_Connection_Handle=%Player_Sprite_Target_Game_Connection_Handle;

Object_Index=%Object_Index;

Health=100;

Sprite_ID_This=0;

Bool_Waiting_For_Move=false;

Bool_Waiting_For_Attack=false;

};

%Composite_Sprite_Summon_Unit.setCollisionGroups(0,25,26,30);

%Composite_Sprite_Summon_Unit.SetBatchLayout("off");

%Composite_Sprite_Summon_Unit.SetBatchSortMode("z");

%Composite_Sprite_Summon_Unit.SetBatchIsolated(true);

%Composite_Sprite_Summon_Unit.Sprite_ID_This=%Composite_Sprite_Summon_Unit.addSprite();

%Composite_Sprite_Summon_Unit.setSpriteLocalPosition(0,0);

%Composite_Sprite_Summon_Unit.setSpriteSize(Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Summon_Unit_Stand_Down));

%Composite_Sprite_Summon_Unit.setSpriteImage("Module_Card_Summon_Unit:Image_Summon_Unit_Stand_Down",0);

%Composite_Sprite_Summon_Unit.SetSpriteDepth(1);

%Collision_Shape_Index=%Composite_Sprite_Summon_Unit.createPolygonBoxCollisionShape(Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Summon_Unit_Stand_Down));

%Composite_Sprite_Summon_Unit.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Composite_Sprite_Summon_Unit.setFixedAngle(true);

%Composite_Sprite_Summon_Unit.Position=%Vector_2D_Position;

%Composite_Sprite_Summon_Unit.Vector_2D_Direction="0 -1";//X,Y

%Composite_Sprite_Summon_Unit.Base_Speed=10;

%Composite_Sprite_Summon_Unit.Current_Speed=10;

%Composite_Sprite_Summon_Unit.Linear_Damping=1;

%Composite_Sprite_Summon_Unit.setLinearDamping(%Composite_Sprite_Summon_Unit.Linear_Damping);

%Composite_Sprite_Summon_Unit.Bool_Is_Mobile=false;

%Composite_Sprite_Summon_Unit.Base_Attack=10;

%Composite_Sprite_Summon_Unit.Current_Attack=10;

Scene_Dots_and_Crits.add(%Composite_Sprite_Summon_Unit);

%Composite_Sprite_Summon_Unit.setUseInputEvents(true);

Window_Dots_and_Crits.addInputListener(%Composite_Sprite_Summon_Unit);

%Composite_Sprite_Summon_Unit.Gui_Menu=%this.Gui_Menu_Create(%Composite_Sprite_Summon_Unit);

%this.Simset_Objects.add(%Composite_Sprite_Summon_Unit);

}
