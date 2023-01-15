BACKUP DATABASE SoftUni TO DISK = 'C:\Users\GabrielNikolov\Desktop\Backups\softuni-backup.bak'
DROP DATABASE SoftUni
RESTORE DATABASE SoftUni FROM DISK = 'C:\Users\GabrielNikolov\Desktop\Backups\softuni-backup.bak'