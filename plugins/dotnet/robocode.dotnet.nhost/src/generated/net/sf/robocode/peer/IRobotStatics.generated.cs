//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.7905
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.robocode.peer {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface IRobotStatics {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isAdvancedRobot();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isTeamRobot();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isInteractiveRobot();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isPaintRobot();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class IRobotStatics_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::net.sf.robocode.peer.@__IRobotStatics.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::net.sf.robocode.peer.IRobotStatics), typeof(global::net.sf.robocode.peer.IRobotStatics_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::net.sf.robocode.peer.IRobotStatics), typeof(global::net.sf.robocode.peer.IRobotStatics_))]
    internal sealed partial class @__IRobotStatics : global::java.lang.Object, global::net.sf.robocode.peer.IRobotStatics {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isAdvancedRobot0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isTeamRobot1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isInteractiveRobot2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isPaintRobot3;
        
        private @__IRobotStatics(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.robocode.peer.@__IRobotStatics.staticClass = @__class;
            global::net.sf.robocode.peer.@__IRobotStatics.j4n_isAdvancedRobot0 = @__env.GetMethodID(global::net.sf.robocode.peer.@__IRobotStatics.staticClass, "isAdvancedRobot", "()Z");
            global::net.sf.robocode.peer.@__IRobotStatics.j4n_isTeamRobot1 = @__env.GetMethodID(global::net.sf.robocode.peer.@__IRobotStatics.staticClass, "isTeamRobot", "()Z");
            global::net.sf.robocode.peer.@__IRobotStatics.j4n_isInteractiveRobot2 = @__env.GetMethodID(global::net.sf.robocode.peer.@__IRobotStatics.staticClass, "isInteractiveRobot", "()Z");
            global::net.sf.robocode.peer.@__IRobotStatics.j4n_isPaintRobot3 = @__env.GetMethodID(global::net.sf.robocode.peer.@__IRobotStatics.staticClass, "isPaintRobot", "()Z");
        }
        
        public bool isAdvancedRobot() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::net.sf.robocode.peer.@__IRobotStatics.j4n_isAdvancedRobot0)));
            }
        }
        
        public bool isTeamRobot() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::net.sf.robocode.peer.@__IRobotStatics.j4n_isTeamRobot1)));
            }
        }
        
        public bool isInteractiveRobot() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::net.sf.robocode.peer.@__IRobotStatics.j4n_isInteractiveRobot2)));
            }
        }
        
        public bool isPaintRobot() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::net.sf.robocode.peer.@__IRobotStatics.j4n_isPaintRobot3)));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IRobotStatics);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isAdvancedRobot", "isAdvancedRobot0", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isTeamRobot", "isTeamRobot1", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isInteractiveRobot", "isInteractiveRobot2", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isPaintRobot", "isPaintRobot3", "()Z"));
            return methods;
        }
        
        private static bool isAdvancedRobot0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::net.sf.robocode.peer.IRobotStatics @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.peer.IRobotStatics>(@__env, @__obj);
            @__return = ((bool)(@__real.isAdvancedRobot()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool isTeamRobot1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::net.sf.robocode.peer.IRobotStatics @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.peer.IRobotStatics>(@__env, @__obj);
            @__return = ((bool)(@__real.isTeamRobot()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool isInteractiveRobot2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::net.sf.robocode.peer.IRobotStatics @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.peer.IRobotStatics>(@__env, @__obj);
            @__return = ((bool)(@__real.isInteractiveRobot()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool isPaintRobot3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::net.sf.robocode.peer.IRobotStatics @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.peer.IRobotStatics>(@__env, @__obj);
            @__return = ((bool)(@__real.isPaintRobot()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.robocode.peer.@__IRobotStatics(@__env);
            }
        }
    }
    #endregion
}
