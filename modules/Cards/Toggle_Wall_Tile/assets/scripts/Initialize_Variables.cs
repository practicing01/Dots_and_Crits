function Module_Card_Toggle_Wall_Tile::Initialize_Variables(%this)
{

%this.Bool_Waiting_For_Target=false;

%this.Card_Target=0;

%this.Bool_Waiting_For_Cast=false;

%this.Scene_Object_Input_Capture=new SceneObject()
{

BodyType="static";
Position="0 0";
size="1 1";
class="Scene_Object_Module_Card_Toggle_Wall_Tile_Input_Capture";
canSaveDynamicFields="1";

Module_ID_Parent=%this;

};

%this.Scene_Object_Input_Capture.setUseInputEvents(true);
Window_Dots_and_Crits.addInputListener(%this.Scene_Object_Input_Capture);

Scene_Dots_and_Crits.add(%this.Scene_Object_Input_Capture);

/************************************************/

%this.Simset_Objects=new SimSet();

%this.Toggle_Wall_Tile_Count=0;

%this.Simset_Player_Information=new SimSet();

%this.Player_Information_This=0;

/************************************************/

}
