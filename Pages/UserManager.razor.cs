﻿using DoAnCS_Demo1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;

namespace DoAnCS_Demo1.Pages
{
    public partial class UserManager
    {
        public bool ShowCreate { get; set; }
        protected override async Task OnInitializedAsync()
        {
            ShowCreate = false;
            await ShowUsers();
        }
        private UserContext? _context;
        public User? NewUser { get; set; }
        public void ShowCreateForm()
        {
            NewUser = new User();
            ShowCreate = true;
        }

        public void CancelCreate()
        {
            NewUser = null;
            ShowCreate = false;
        }
        //public async Task CreateNewUser()
        //{
        //    _context ??= await UserContextFactory.CreateDbContextAsync();

        //    if (NewUser is not null)
        //    {
        //        _context?.Users.Add(NewUser);
        //        _context?.SaveChangesAsync();
        //    }
        //    ShowCreate = false;
        //}

        // GPT can fix this, no way
        public async Task CreateNewUser()
        {
            using var context = await UserContextFactory.CreateDbContextAsync();

            if (NewUser is not null)
            {
                context.Users.Add(NewUser);
                await context.SaveChangesAsync();
            }

            ShowCreate = false;

            // alert add complete
            try
            {
                await JSRuntime.InvokeVoidAsync("alert", "Add complete");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                await JSRuntime.InvokeVoidAsync("alert", "Add fail");
            }

            RefreshPage();
        }


        public List<User>? Users { get; set; }
        public async Task ShowUsers()
        {
            _context ??= await UserContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                Users = await _context.Users.ToListAsync();
            }

            if (_context is not null)
            {
                await _context.DisposeAsync();
            }
        }


        //Start edit/update
        public bool EditRecord { get; set; }
        public int? EditingID { get; set; }
        public User? UserToUpdate { get; set; }

        //public async Task ShowEditForm(User user)
        //{
        //    _context ??= await UserContextFactory.CreateDbContextAsync();

        //    UserToUpdate = _context.Users.FirstOrDefault(x => x.Id == user.Id);
        //    EditingID = user.Id;
        //    EditRecord = true;
        //}

        private async Task ShowEditForm(User user)
        {
            _context = await UserContextFactory.CreateDbContextAsync();

            // Here, you should rely on dependency injection for the DbContext.
            UserToUpdate = _context.Users.Where(x => x.Id == user.Id).FirstOrDefault();
            EditingID = user.Id;
            EditRecord = true;
        }

        public async Task UpdateUser()
        {



            EditRecord = false;
            _context ??= await UserContextFactory.CreateDbContextAsync();
            if (_context is not null)
            {
                if (UserToUpdate is not null)
                {
                    _context?.Users.Update(UserToUpdate);

                }
                await _context.SaveChangesAsync();
                await _context.DisposeAsync();

                RefreshPage();
            }
        }

        // end edit/update

        private void RefreshPage()
        {
            // Use JavaScript to refresh the page.
            JSRuntime.InvokeVoidAsync("location.reload");
        }


        //Start delete
        public async Task DeleteUser(User user)
        {
            _context ??= await UserContextFactory.CreateDbContextAsync();

            // alert to confirm delete
            if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete {user.username}?"))
            {
                return;
            }

            if (_context is not null)
            {
                if (user is not null)
                    _context.Users.Remove(user);
                await _context.SaveChangesAsync();

                
            }
            await ShowUsers();
            RefreshPage();
        }
    }
}
