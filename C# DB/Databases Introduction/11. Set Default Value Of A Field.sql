ALTER TABLE Users
ADD CONSTRAINT DF_LastLoginTime DEFAULT CURRENT_TIMESTAMP FOR [LastLoginTime]