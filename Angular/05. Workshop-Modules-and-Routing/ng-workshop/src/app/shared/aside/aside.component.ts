import { Component, OnInit } from '@angular/core';
import { PostService } from '../../post.service';
import { IPost } from '../interfaces/post';

@Component({
  selector: 'app-aside',
  templateUrl: './aside.component.html',
  styleUrls: ['./aside.component.css'],
})
export class AsideComponent implements OnInit {
  postList: IPost[];

  constructor(private postService: PostService) {}

  ngOnInit(): void {
    this.postService.loadPostList(5).subscribe((postList) => {
      this.postList = postList;
    });
  }
}
