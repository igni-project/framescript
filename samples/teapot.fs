// A simple FrameScript demo.

// 1. Import the Utah teapot model into the scene
const teapot = scene.importAsset("assets/teapot.obj");

// 2. Point viewpoint at teapot

// 2a. Set location of viewpoint
scene.setViewLoc(4.26, 6.97, 2.94);

// 2b. Set rotation of viewpoint
scene.setViewRot(75, 0, 148);

// 2c. Set viewpoint field of view
scene.setViewFov(45);

// 3. Make the teapot visible
teapot.show();

