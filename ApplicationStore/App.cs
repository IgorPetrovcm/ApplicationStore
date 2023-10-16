using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSD//Main Struct Data
{
    public class App
    {
        byte id;
        byte[] image;
        string name;
        string description;
        byte roleId;
        byte userId;
        bool restrictions;

        public byte Id { get { return id; } set {  id = value; } }
        public byte[] Image { get { return image; } set { image = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public byte RoleId { get {  return roleId; } set {  roleId = value; } }
        public byte UserId { get { return userId; } set { userId = value; } }
        public bool Restrictions { get {  return restrictions; } set {  restrictions = value; } }

        public App(
            byte id,
            byte[] image,
            string name,
            string description,
            byte roleId,
            byte userId,
            bool restrictions
            )
        {
            Id = id;
            Image = image; 
            Name = name;
            Description = description;
            RoleId = roleId;
            UserId = userId;
            Restrictions = restrictions;
        }
    }
}
