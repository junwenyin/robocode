//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.7905
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.robocode.host {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface IHost {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lnet/sf/robocode/host/IHostManager;Lrobocode/control/RobotSpecification;Lnet/sf/" +
            "robocode/peer/IRobotStatics;Lnet/sf/robocode/peer/IRobotPeer;)Lnet/sf/robocode/h" +
            "ost/proxies/IHostingRobotProxy;")]
        global::net.sf.robocode.host.proxies.IHostingRobotProxy createRobotProxy(global::net.sf.robocode.host.IHostManager par0, global::java.lang.Object par1, global::net.sf.robocode.peer.IRobotStatics par2, global::net.sf.robocode.peer.IRobotPeer par3);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lnet/sf/robocode/repository/IRobotItem;)[Ljava/lang/String;")]
        java.lang.String[] getReferencedClasses(global::net.sf.robocode.repository.IRobotItem par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lnet/sf/robocode/repository/IRobotItem;ZZ)Lnet/sf/robocode/repository/RobotType;" +
            "")]
        global::net.sf.robocode.repository.RobotType getRobotType(global::net.sf.robocode.repository.IRobotItem par0, bool par1, bool par2);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class IHost_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::net.sf.robocode.host.@__IHost.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::net.sf.robocode.host.IHost), typeof(global::net.sf.robocode.host.IHost_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::net.sf.robocode.host.IHost), typeof(global::net.sf.robocode.host.IHost_))]
    internal sealed partial class @__IHost : global::java.lang.Object, global::net.sf.robocode.host.IHost {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_createRobotProxy0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getReferencedClasses1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getRobotType2;
        
        private @__IHost(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.robocode.host.@__IHost.staticClass = @__class;
            global::net.sf.robocode.host.@__IHost.j4n_createRobotProxy0 = @__env.GetMethodID(global::net.sf.robocode.host.@__IHost.staticClass, "createRobotProxy", "(Lnet/sf/robocode/host/IHostManager;Lrobocode/control/RobotSpecification;Lnet/sf/" +
                    "robocode/peer/IRobotStatics;Lnet/sf/robocode/peer/IRobotPeer;)Lnet/sf/robocode/h" +
                    "ost/proxies/IHostingRobotProxy;");
            global::net.sf.robocode.host.@__IHost.j4n_getReferencedClasses1 = @__env.GetMethodID(global::net.sf.robocode.host.@__IHost.staticClass, "getReferencedClasses", "(Lnet/sf/robocode/repository/IRobotItem;)[Ljava/lang/String;");
            global::net.sf.robocode.host.@__IHost.j4n_getRobotType2 = @__env.GetMethodID(global::net.sf.robocode.host.@__IHost.staticClass, "getRobotType", "(Lnet/sf/robocode/repository/IRobotItem;ZZ)Lnet/sf/robocode/repository/RobotType;" +
                    "");
        }
        
        public global::net.sf.robocode.host.proxies.IHostingRobotProxy createRobotProxy(global::net.sf.robocode.host.IHostManager par0, global::java.lang.Object par1, global::net.sf.robocode.peer.IRobotStatics par2, global::net.sf.robocode.peer.IRobotPeer par3) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 18)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.host.proxies.IHostingRobotProxy>(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.robocode.host.@__IHost.j4n_createRobotProxy0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::net.sf.robocode.host.IHostManager>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::net.sf.robocode.peer.IRobotStatics>(@__env, par2), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::net.sf.robocode.peer.IRobotPeer>(@__env, par3)));
            }
        }
        
        public java.lang.String[] getReferencedClasses(global::net.sf.robocode.repository.IRobotItem par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.robocode.host.@__IHost.j4n_getReferencedClasses1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::net.sf.robocode.repository.IRobotItem>(@__env, par0)));
            }
        }
        
        public global::net.sf.robocode.repository.RobotType getRobotType(global::net.sf.robocode.repository.IRobotItem par0, bool par1, bool par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::net.sf.robocode.repository.RobotType>(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.robocode.host.@__IHost.j4n_getRobotType2, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::net.sf.robocode.repository.IRobotItem>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2)));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IHost);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "createRobotProxy", "createRobotProxy0", "(Lnet/sf/robocode/host/IHostManager;Lrobocode/control/RobotSpecification;Lnet/sf/" +
                        "robocode/peer/IRobotStatics;Lnet/sf/robocode/peer/IRobotPeer;)Lnet/sf/robocode/h" +
                        "ost/proxies/IHostingRobotProxy;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getReferencedClasses", "getReferencedClasses1", "(Lnet/sf/robocode/repository/IRobotItem;)[Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getRobotType", "getRobotType2", "(Lnet/sf/robocode/repository/IRobotItem;ZZ)Lnet/sf/robocode/repository/RobotType;" +
                        ""));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle createRobotProxy0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1, global::net.sf.jni4net.utils.JniLocalHandle par2, global::net.sf.jni4net.utils.JniLocalHandle par3) {
            // (Lnet/sf/robocode/host/IHostManager;Lrobocode/control/RobotSpecification;Lnet/sf/robocode/peer/IRobotStatics;Lnet/sf/robocode/peer/IRobotPeer;)Lnet/sf/robocode/host/proxies/IHostingRobotProxy;
            // (Lnet/sf/robocode/host/IHostManager;Ljava/lang/Object;Lnet/sf/robocode/peer/IRobotStatics;Lnet/sf/robocode/peer/IRobotPeer;)Lnet/sf/robocode/host/proxies/IHostingRobotProxy;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::net.sf.robocode.host.IHost @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.host.IHost>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::net.sf.robocode.host.proxies.IHostingRobotProxy>(@__env, @__real.createRobotProxy(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.host.IHostManager>(@__env, par0), global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, par1), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.peer.IRobotStatics>(@__env, par2), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.peer.IRobotPeer>(@__env, par3)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getReferencedClasses1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lnet/sf/robocode/repository/IRobotItem;)[Ljava/lang/String;
            // (Lnet/sf/robocode/repository/IRobotItem;)[Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::net.sf.robocode.host.IHost @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.host.IHost>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayStrongCp2J(@__env, @__real.getReferencedClasses(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.repository.IRobotItem>(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getRobotType2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, bool par1, bool par2) {
            // (Lnet/sf/robocode/repository/IRobotItem;ZZ)Lnet/sf/robocode/repository/RobotType;
            // (Lnet/sf/robocode/repository/IRobotItem;ZZ)Lnet/sf/robocode/repository/RobotType;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::net.sf.robocode.host.IHost @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.host.IHost>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getRobotType(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.repository.IRobotItem>(@__env, par0), par1, par2));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.robocode.host.@__IHost(@__env);
            }
        }
    }
    #endregion
}
