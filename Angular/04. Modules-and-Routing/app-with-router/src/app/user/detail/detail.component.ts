import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { UserService } from '../user.service';
import { tap, switchMap } from 'rxjs/operators';

@Component({
  selector: 'app-detail',
  templateUrl: './detail.component.html',
  styleUrls: ['./detail.component.css'],
})
export class DetailComponent implements OnInit {
  user = null;

  constructor(
    private userService: UserService,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.route.params
      .pipe(
        tap(() => (this.user = null)),
        switchMap(({ id }) => this.userService.loadUser(id))
      )
      .subscribe((user) => {
        this.user = user;
      });

    // const userId = this.router.snapshot.params['id'];
    // this.userService.loadUser(userId).subscribe(user => {
    //     this.user = user;
    // });
  }
}
