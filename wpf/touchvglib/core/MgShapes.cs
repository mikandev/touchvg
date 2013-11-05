/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace touchvg.core {

using System;
using System.Runtime.InteropServices;

public class MgShapes : MgObject {
  private HandleRef swigCPtr;

  internal MgShapes(IntPtr cPtr, bool cMemoryOwn) : base(touchvgPINVOKE.MgShapes_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MgShapes obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static int Type() {
    int ret = touchvgPINVOKE.MgShapes_Type();
    return ret;
  }

  public MgShapes cloneShapes() {
    IntPtr cPtr = touchvgPINVOKE.MgShapes_cloneShapes(swigCPtr);
    MgShapes ret = (cPtr == IntPtr.Zero) ? null : new MgShapes(cPtr, false);
    return ret;
  }

  public static MgShapes create(MgObject owner, int index) {
    IntPtr cPtr = touchvgPINVOKE.MgShapes_create__SWIG_0(MgObject.getCPtr(owner), index);
    MgShapes ret = (cPtr == IntPtr.Zero) ? null : new MgShapes(cPtr, false);
    return ret;
  }

  public static MgShapes create(MgObject owner) {
    IntPtr cPtr = touchvgPINVOKE.MgShapes_create__SWIG_1(MgObject.getCPtr(owner));
    MgShapes ret = (cPtr == IntPtr.Zero) ? null : new MgShapes(cPtr, false);
    return ret;
  }

  public static MgShapes create() {
    IntPtr cPtr = touchvgPINVOKE.MgShapes_create__SWIG_2();
    MgShapes ret = (cPtr == IntPtr.Zero) ? null : new MgShapes(cPtr, false);
    return ret;
  }

  public MgShape addShapeByType(MgShapeFactory factory, int type) {
    IntPtr cPtr = touchvgPINVOKE.MgShapes_addShapeByType(swigCPtr, MgShapeFactory.getCPtr(factory), type);
    MgShape ret = (cPtr == IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public int getShapeCount() {
    int ret = touchvgPINVOKE.MgShapes_getShapeCount(swigCPtr);
    return ret;
  }

  public MgShape getHeadShape() {
    IntPtr cPtr = touchvgPINVOKE.MgShapes_getHeadShape(swigCPtr);
    MgShape ret = (cPtr == IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public MgShape getLastShape() {
    IntPtr cPtr = touchvgPINVOKE.MgShapes_getLastShape(swigCPtr);
    MgShape ret = (cPtr == IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public MgShape findShape(int sid) {
    IntPtr cPtr = touchvgPINVOKE.MgShapes_findShape(swigCPtr, sid);
    MgShape ret = (cPtr == IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public MgShape findShapeByTag(int tag) {
    IntPtr cPtr = touchvgPINVOKE.MgShapes_findShapeByTag(swigCPtr, tag);
    MgShape ret = (cPtr == IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public MgShape findShapeByType(int type) {
    IntPtr cPtr = touchvgPINVOKE.MgShapes_findShapeByType(swigCPtr, type);
    MgShape ret = (cPtr == IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public Box2d getExtent() {
    Box2d ret = new Box2d(touchvgPINVOKE.MgShapes_getExtent(swigCPtr), true);
    return ret;
  }

  public MgShape hitTest(Box2d limits, MgHitResult res) {
    IntPtr cPtr = touchvgPINVOKE.MgShapes_hitTest(swigCPtr, Box2d.getCPtr(limits), MgHitResult.getCPtr(res));
    MgShape ret = (cPtr == IntPtr.Zero) ? null : new MgShape(cPtr, false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int draw(GiGraphics gs, GiContext ctx) {
    int ret = touchvgPINVOKE.MgShapes_draw__SWIG_0(swigCPtr, GiGraphics.getCPtr(gs), GiContext.getCPtr(ctx));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int draw(GiGraphics gs) {
    int ret = touchvgPINVOKE.MgShapes_draw__SWIG_1(swigCPtr, GiGraphics.getCPtr(gs));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int dyndraw(int mode, GiGraphics gs, GiContext ctx, int segment) {
    int ret = touchvgPINVOKE.MgShapes_dyndraw(swigCPtr, mode, GiGraphics.getCPtr(gs), GiContext.getCPtr(ctx), segment);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save(MgStorage s, int startIndex) {
    bool ret = touchvgPINVOKE.MgShapes_save__SWIG_0(swigCPtr, MgStorage.getCPtr(s), startIndex);
    return ret;
  }

  public bool save(MgStorage s) {
    bool ret = touchvgPINVOKE.MgShapes_save__SWIG_1(swigCPtr, MgStorage.getCPtr(s));
    return ret;
  }

  public bool load(MgShapeFactory factory, MgStorage s, bool addOnly) {
    bool ret = touchvgPINVOKE.MgShapes_load__SWIG_0(swigCPtr, MgShapeFactory.getCPtr(factory), MgStorage.getCPtr(s), addOnly);
    return ret;
  }

  public bool load(MgShapeFactory factory, MgStorage s) {
    bool ret = touchvgPINVOKE.MgShapes_load__SWIG_1(swigCPtr, MgShapeFactory.getCPtr(factory), MgStorage.getCPtr(s));
    return ret;
  }

  public void clear() {
    touchvgPINVOKE.MgShapes_clear(swigCPtr);
  }

  public void clearCachedData() {
    touchvgPINVOKE.MgShapes_clearCachedData(swigCPtr);
  }

  public void copyShapes(MgShapes src) {
    touchvgPINVOKE.MgShapes_copyShapes(swigCPtr, MgShapes.getCPtr(src));
  }

  public MgShape addShape(MgShape src) {
    IntPtr cPtr = touchvgPINVOKE.MgShapes_addShape(swigCPtr, MgShape.getCPtr(src));
    MgShape ret = (cPtr == IntPtr.Zero) ? null : new MgShape(cPtr, false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MgShape removeShape(int sid, bool skipLockedShape) {
    IntPtr cPtr = touchvgPINVOKE.MgShapes_removeShape__SWIG_0(swigCPtr, sid, skipLockedShape);
    MgShape ret = (cPtr == IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public MgShape removeShape(int sid) {
    IntPtr cPtr = touchvgPINVOKE.MgShapes_removeShape__SWIG_1(swigCPtr, sid);
    MgShape ret = (cPtr == IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public MgShape moveTo(int sid, MgShapes dest) {
    IntPtr cPtr = touchvgPINVOKE.MgShapes_moveTo(swigCPtr, sid, MgShapes.getCPtr(dest));
    MgShape ret = (cPtr == IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public void moveAllShapesTo(MgShapes dest) {
    touchvgPINVOKE.MgShapes_moveAllShapesTo(swigCPtr, MgShapes.getCPtr(dest));
  }

  public bool bringToFront(int sid) {
    bool ret = touchvgPINVOKE.MgShapes_bringToFront(swigCPtr, sid);
    return ret;
  }

  public MgObject getOwner() {
    IntPtr cPtr = touchvgPINVOKE.MgShapes_getOwner(swigCPtr);
    MgObject ret = (cPtr == IntPtr.Zero) ? null : new MgObject(cPtr, false);
    return ret;
  }

  public static MgShapes fromHandle(int h) {
    IntPtr cPtr = touchvgPINVOKE.MgShapes_fromHandle(h);
    MgShapes ret = (cPtr == IntPtr.Zero) ? null : new MgShapes(cPtr, false);
    return ret;
  }

  public int toHandle() {
    int ret = touchvgPINVOKE.MgShapes_toHandle(swigCPtr);
    return ret;
  }

  public override MgObject clone() {
    IntPtr cPtr = touchvgPINVOKE.MgShapes_clone(swigCPtr);
    MgObject ret = (cPtr == IntPtr.Zero) ? null : new MgObject(cPtr, false);
    return ret;
  }

  public override void copy(MgObject src) {
    touchvgPINVOKE.MgShapes_copy(swigCPtr, MgObject.getCPtr(src));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void release() {
    touchvgPINVOKE.MgShapes_release(swigCPtr);
  }

  public override bool equals(MgObject src) {
    bool ret = touchvgPINVOKE.MgShapes_equals(swigCPtr, MgObject.getCPtr(src));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int getType() {
    int ret = touchvgPINVOKE.MgShapes_getType(swigCPtr);
    return ret;
  }

  public override bool isKindOf(int type) {
    bool ret = touchvgPINVOKE.MgShapes_isKindOf(swigCPtr, type);
    return ret;
  }

}

}
