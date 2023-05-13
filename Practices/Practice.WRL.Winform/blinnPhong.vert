// Blinn-Phong-WorldSpace.vert
#version 150

in vec3 inPosition;
in vec3 inNormal;

// Declare an interface block.
out _Vertex {
    vec3 position;
	vec3 normal;
} v;

uniform mat4 mvpMat;
uniform mat4 modelMat;
uniform mat4 normalMat; // transpose(inverse(modelMat));

void main() {
    gl_Position = mvpMat * vec4(inPosition, 1.0);
    vec4 worldSpacePos = modelMat * vec4(inPosition, 1.0);
	v.position = worldSpacePos.xyz;
	v.normal = (normalMat * vec4(inNormal, 0)).xyz;
}

