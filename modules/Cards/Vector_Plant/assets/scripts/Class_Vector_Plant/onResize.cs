function Class_Vector_Plant::onResize(%this)
{

%this.clearCollisionShapes();

%Radius=0;

if (%this.Size.X>%this.Size.Y){%Radius=%this.Size.X/2;}else{%Radius=%this.Size.Y/2;}

%this.createCircleCollisionShape(%Radius);

}
