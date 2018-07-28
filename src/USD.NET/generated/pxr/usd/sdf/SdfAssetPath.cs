//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class SdfAssetPath : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SdfAssetPath(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfAssetPath obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SdfAssetPath() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_SdfAssetPath(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SdfAssetPath() : this(UsdCsPINVOKE.new_SdfAssetPath__SWIG_0(), true) {
  }

  public SdfAssetPath(string path) : this(UsdCsPINVOKE.new_SdfAssetPath__SWIG_1(path), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SdfAssetPath(string path, string resolvedPath) : this(UsdCsPINVOKE.new_SdfAssetPath__SWIG_2(path, resolvedPath), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetHash() {
    uint ret = UsdCsPINVOKE.SdfAssetPath_GetHash(swigCPtr);
    return ret;
  }

  public string GetAssetPath() {
    string ret = UsdCsPINVOKE.SdfAssetPath_GetAssetPath(swigCPtr);
    return ret;
  }

  public string GetResolvedPath() {
    string ret = UsdCsPINVOKE.SdfAssetPath_GetResolvedPath(swigCPtr);
    return ret;
  }

  public static bool Equals(SdfAssetPath lhs, SdfAssetPath rhs) {
    bool ret = UsdCsPINVOKE.SdfAssetPath_Equals(SdfAssetPath.getCPtr(lhs), SdfAssetPath.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  override public int GetHashCode() {
    int ret = UsdCsPINVOKE.SdfAssetPath_GetHashCode(swigCPtr);
    return ret;
  }

    public static bool operator==(SdfAssetPath lhs, SdfAssetPath rhs){
	    // The Swig binding glue will re-enter this operator comparing to null, so 
	    // that case must be handled explicitly to avoid an infinite loop. This is still
	    // not great, since it crosses the C#/C++ barrier twice. A better approache might
	    // be to return a simple value from C++ that can be compared in C#.
      bool lnull = lhs as object == null;
      bool rnull = rhs as object == null;
      return (lnull == rnull) && ((lnull && rnull) || SdfAssetPath.Equals(lhs, rhs));
    }

    public static bool operator !=(SdfAssetPath lhs, SdfAssetPath rhs) {
        return !(lhs == rhs);
    }

	  override public bool Equals(object rhs) {
		  return SdfAssetPath.Equals(this, rhs as SdfAssetPath);
	  }
  
}

}
