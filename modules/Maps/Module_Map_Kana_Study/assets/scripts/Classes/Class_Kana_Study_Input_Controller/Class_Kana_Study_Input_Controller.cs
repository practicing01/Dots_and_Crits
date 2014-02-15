function Class_Kana_Study_Input_Controller::onMouseWheelUp(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

Window_Dots_and_Crits.setCameraZoom(Window_Dots_and_Crits.getCameraZoom()+$pref::Dots_and_Crits::cameraMouseZoomRate);

}

function Class_Kana_Study_Input_Controller::onMouseWheelDown(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

Window_Dots_and_Crits.setCameraZoom(Window_Dots_and_Crits.getCameraZoom()-$pref::Dots_and_Crits::cameraMouseZoomRate);

}
