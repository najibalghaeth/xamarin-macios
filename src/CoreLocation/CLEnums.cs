//
// Authors:
//   Miguel de Icaza (miguel@gnome.org)
//   Aaron Bockover (abock@xamarin.com)
//
// Copyright 2011-2014 Xamarin Inc
//
// The class can be either constructed from a string (from user code)
// or from a handle (from iphone-sharp.dll internal calls).  This
// delays the creation of the actual managed string until actually
// required
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using System;
using XamCore.ObjCRuntime;

namespace XamCore.CoreLocation {

	// NSInteger -> CLError.h
	[Native]
	public enum CLError : nint {
		LocationUnknown  = 0,
		Denied,              
		Network,             
		HeadingFailure,

		[iOS (4,0)]
		RegionMonitoringDenied,
		[iOS (4,0)]
		RegionMonitoringFailure,
		[iOS (4,0)]
		RegionMonitoringSetupDelayed,
		
		// ios5 osx10.8
		RegionMonitoringResponseDelayed,
		// ios5 osx10.7
		GeocodeFoundNoResult,
		// ios5 osx10.8
		GeocodeFoundPartialResult,
		// ios5 osx10.7
		GeocodeCanceled,

		// ios6
		DeferredFailed,
		DeferredNotUpdatingLocation,
		DeferredAccuracyTooLow,
		DeferredDistanceFiltered,
		DeferredCanceled,

		// ios7
		RangingFailure,
		RangingUnavailable
	}

	// untyped enum -> CLLocationManager.h
	public enum CLDeviceOrientation : uint_compat_int {
		Unknown,
		Portrait,
		PortraitUpsideDown,
		LandscapeLeft,
		LandscapeRight,
		FaceUp,
		FaceDown
	} 

	// untyped enum -> CLLocationManager.h
	public enum CLAuthorizationStatus : uint_compat_int {
		NotDetermined = 0,
		Restricted,
		Denied,

		[Deprecated (PlatformName.iOS, 8, 0, message : "Use 'AuthorizedAlways' instead.")]
		Authorized,
		AuthorizedAlways = Authorized,
		AuthorizedWhenInUse			
	}

	// NSInteger -> CLLocationManager.h
	[Native]
	public enum CLActivityType : nint {
		Other = 1,
		AutomotiveNavigation,
 		Fitness,
		OtherNavigation
    }
}
