function Window_Create_Dots_and_Crits()
{

if (!isObject(Window_Dots_and_Crits))
{

new SceneWindow(Window_Dots_and_Crits);   

Window_Dots_and_Crits.Profile=Gui_Profile_Window_Dots_and_Crits;

Canvas.setContent(Window_Dots_and_Crits);                     

}

Window_Dots_and_Crits.stopCameraMove();
Window_Dots_and_Crits.dismount();
Window_Dots_and_Crits.setViewLimitOff();
Window_Dots_and_Crits.setRenderGroups($All_Bits);
Window_Dots_and_Crits.setRenderLayers($All_Bits);
Window_Dots_and_Crits.setObjectInputEventGroupFilter($All_Bits);
Window_Dots_and_Crits.setObjectInputEventLayerFilter($All_Bits);
Window_Dots_and_Crits.setLockMouse(true);
Window_Dots_and_Crits.setCameraPosition(0,0);
Window_Dots_and_Crits.setCameraZoom(1);
Window_Dots_and_Crits.setCameraAngle(0);

$Resolution=getRes();
%Y_Times_100=100*$Resolution.Y;
%Cam_Y=%Y_Times_100/$Resolution.X;

Window_Dots_and_Crits.setCameraSize(100,%Cam_Y);

if (!isObject(Gui_Dots_and_Crits_Overlay))
{

new GuiControl(Gui_Dots_and_Crits_Overlay)
{

Position="0 0";
Extent=$Resolution;
Profile=gui_profile_modalless;

};   

Window_Dots_and_Crits.addGuiControl(Gui_Dots_and_Crits_Overlay);

Gui_Dots_and_Crits_Overlay.setActive(true);

}

}

//-----------------------------------------------------------------------------

function Window_Destroy_Dots_and_Crits()
{
    
if (isObject(Window_Dots_and_Crits))
{

Window_Dots_and_Crits.delete();

}

}

//-----------------------------------------------------------------------------

function Scene_Destroy_Dots_and_Crits()
{

if (isObject(Scene_Dots_and_Crits))
{

Cancel_All_Schedules();

Scene_Dots_and_Crits.delete();

}

}

function Scene_Set_To_Window()
{

if (!isObject(Scene_Dots_and_Crits))
{

error("Cannot set Dots_and_Crits Scene to Window as the Scene is invalid.");
return;

}
    
Window_Dots_and_Crits.setScene(Scene_Dots_and_Crits);

Window_Dots_and_Crits.stopCameraMove();
Window_Dots_and_Crits.dismount();
Window_Dots_and_Crits.setViewLimitOff();
Window_Dots_and_Crits.setRenderGroups($All_Bits);
Window_Dots_and_Crits.setRenderLayers($All_Bits);
Window_Dots_and_Crits.setObjectInputEventGroupFilter($All_Bits);
Window_Dots_and_Crits.setObjectInputEventLayerFilter($All_Bits);
Window_Dots_and_Crits.setLockMouse(true);
Window_Dots_and_Crits.setCameraPosition(0,0);
Window_Dots_and_Crits.setCameraZoom(1);
Window_Dots_and_Crits.setCameraAngle(0);

$Resolution=getRes();
%Y_Times_100=100*$Resolution.Y;
%Cam_Y=%Y_Times_100/$Resolution.X;

Window_Dots_and_Crits.setCameraSize(100,%Cam_Y);

}

function Scene_Create_Dots_and_Crits()
{

Scene_Destroy_Dots_and_Crits();

new Scene(Scene_Dots_and_Crits);

if (!isObject(Window_Dots_and_Crits))
{

error("Dots_and_Crits: Created scene but no window available.");
return;

}

Scene_Set_To_Window();    
}

function Scene_Set_Custom(%Scene)
{

if (!isObject(%Scene))
{

error("Cannot set Dots_and_Crits to use an invalid Scene.");
return;

}
   
Scene_Destroy_Dots_and_Crits();

%Scene.setName("Scene_Dots_and_Crits");

//%Scene.class="Class_Scene_Dots_and_Crits";

Scene_Set_To_Window();

}

//-----------------------------------------------------------------------------

/*function Class_Scene_Dots_and_Crits::onSceneCollision(%this,%Scene_Object_0,%Scene_Object_1,%Collision_Details)
{

echo(%Scene_Object_0.class);

echo(%Scene_Object_1.class);

}*/
