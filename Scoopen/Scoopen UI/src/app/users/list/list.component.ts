import { Component, OnInit } from '@angular/core';
import { first } from 'rxjs/operators';

import { UserService } from 'src/app/core/services/user.service';
import { User } from 'src/app/core/models/user';

@Component({ templateUrl: 'list.component.html' })
export class ListComponent implements OnInit {
    users!: User[];

    constructor(private userService: UserService) {}

    ngOnInit() {
        this.userService.getAll()
            .pipe(first())
            .subscribe(users => this.users = users);
    }

    deleteUser(id: string) {
        const user = this.users.find(x => x.id === id);
        if (!user) return;
        user.isDeleting = true;
        this.userService.delete(id)
            .pipe(first())
            .subscribe(() => this.users = this.users.filter(x => x.id !== id));
    }
}