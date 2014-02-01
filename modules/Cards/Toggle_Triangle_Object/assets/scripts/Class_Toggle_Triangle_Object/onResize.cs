function Class_Toggle_Triangle_Object::onResize(%this)
{

%this.clearCollisionShapes();

%this.createPolygonCollisionShape
(
"0" SPC %this.Size.Y/2 SPC
%this.Size.X/2 SPC -(%this.Size.Y/2) SPC
(-(%this.Size.X/2)) SPC -(%this.Size.Y/2)
);

}
