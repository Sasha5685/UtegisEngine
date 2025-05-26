using OpenTK;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
namespace UtegisEngine
{
    public class EngineWindow : GameWindow
    {
        public EngineWindow()
            : base(GameWindowSettings.Default, NativeWindowSettings.Default)
        {
            this.CenterWindow(new Vector2i(1280, 768));
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);
        }
        protected override void OnRenderFrame(FrameEventArgs args)
        {
            GL.ClearColor(new Color4(0.1f,0.5f, 0.9f, 1f));
            GL.Clear(ClearBufferMask.ColorBufferBit);
             
            this.Context.SwapBuffers();
            base.OnRenderFrame(args);
        }
    }
}
