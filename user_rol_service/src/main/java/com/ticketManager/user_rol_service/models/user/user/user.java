package com.ticketManager.user_rol_service.models.user.user;

import jakarta.persistence.*;
import lombok.Data;

@Entity(name = "user")
@Table(name = "\"user\"",schema = "public")
@Data()
public class user {
    @Id
    @Column(name = "id",length = 10,nullable = false)
    @GeneratedValue()
    Long id;
    @Column(name = "name",length = 10,nullable = false)
    string name;
    @Column(name = "password",length = 10,nullable = false)
    string password;
}
