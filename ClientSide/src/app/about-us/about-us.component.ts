import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';

@Component({
  selector: 'app-about-us',
  templateUrl: './about-us.component.html',
  styleUrls: ['./about-us.component.css']
  })
export class AboutUsComponent implements OnInit {

  constructor() { }
  @ViewChild('videoPlayer') videoplayer: ElementRef;

  ngOnInit(): void {
    var myVideo: any = document.getElementById("my_video_1");
  myVideo.play();
  }
  toggleVideo() {
    this.videoplayer.nativeElement.play();
}
playPause() {
  var myVideo: any = document.getElementById("my_video_1");
  if (myVideo.paused) myVideo.play();
  else myVideo.pause();
}
myImage:string="assets/img/logopinko.png";
}
