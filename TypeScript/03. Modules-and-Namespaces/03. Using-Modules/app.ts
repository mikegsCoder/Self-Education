// ---------- modules example ----------
import { Phone, call } from './devices';
// import {Phone, call as makeCall} from './devices.ts';
// import {Phone, makeCall} from './devices.ts';

let iphone: Phone = new Phone('iPhone X');
call(iphone);  // Make a call by iPhone X

// ---------- default export example ----------
import SmartWatch from './smartwatch';

let watch: SmartWatch = new SmartWatch('Apple Watch');
watch.printModel();  // Model: Apple Watch
