# CCP Password and Email Breach Checker
[![Build status](https://ci.appveyor.com/api/projects/status/kiwninoh7iwpxb5j/branch/master?svg=true)](https://ci.appveyor.com/project/ccp-aus/passwordcheck/branch/master) [![Release](https://img.shields.io/github/release/ccp-aus/passwordcheck.svg)](https://github.com/ccp-aus/passwordcheck/releases)

## Overview
This tool was primarily written for customers of CCP in Perth, Australia so that they can check their passwords and email addresses for any potential data breaches that may warrant password changes or extra security measures. It has been released open source as a trust gesture to show anyone that's interested that there's no transmission of any passwords to any 3rd party services.

## Download
https://github.com/ccp-aus/passwordcheck/releases/latest

## Password Check
Uses the Have I Been Pwned website API's range method to submit the bare minimum amount of data. An SHA-1 hash of the password is generated and the first 5 characters are sent to the service. The service returns a list of hash suffixes that match those 5 characters. This means the password, nor the hash, is ever in the same transmission as a whole string.

More information can be found here: https://www.troyhunt.com/ive-just-launched-pwned-passwords-version-2/

*While we added a "Show Passwords" eye icon to enable users to check what they've typed in, please be advised that security is still important and to make sure nobody is looking over your shoulder when you use it.*

## Email Check
Just a simple email address check. It uses the Have I Been Pwned API to again submit the email address and gets a result. If there are breaches detected, users are offered the option to load the Have I been Pwned web page to get more information.
