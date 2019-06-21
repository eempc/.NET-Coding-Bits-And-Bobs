            int methodMethod = player.DaysSinceLastLogin.GetValueOrDefault(-1); // -1 is default
            int ternaryMethod = (player.DaysSinceLastLogin.HasValue) ? player.DaysSinceLastLogin.Value : -1;
            int nullCoalescingOperator = player.DaysSinceLastLogin ?? -1;
            
            int x = 142;
            int? y = x;
            int z = (int)y;
            Console.WriteLine(z);

            PlayerCharacter[] players = new PlayerCharacter[3] {
                new PlayerCharacter {Name = "Sarah"},
                new PlayerCharacter(),
                null
            };

            string p1 = players?[0]?.Name ?? "-";
            string p2 = players?[0]?.Name ?? "-";
            string p3 = players?[0]?.Name ?? "-";
