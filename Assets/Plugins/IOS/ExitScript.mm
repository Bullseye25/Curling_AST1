//
//  ViewController.m
//  AppCu
//
//  Created by Ammad Raza on 5/26/17.
//  Copyright (c) 2017 Ammad Raza. All rights reserved.
//

#import "ExitScript.h"
#import "AppDelegate.h"

extern "C"
{
    void _EndUnityButtonTouched()
    {
        NSLog("It Working");
        
        [(AppDelegate *)[UIApplication sharedApplication].delegate hideUnityWindow];
    }
}
