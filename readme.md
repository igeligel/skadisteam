# Skadisteam

## Packages - Core
| Package          | Github Repository                                                         | Nuget Package                                                        | Version |  Build Status - Windows |
| ---------------- | ------------------------------------------------------------------------- | -------------------------------------------------------------------- | ------------- | ----------------------- |
| skadisteam.login | [igeligel/skadisteam.login](https://github.com/igeligel/skadisteam.login) | [skadisteam.login](https://www.nuget.org/packages/skadisteam.login/) | 0.1.2-beta    | [![Build status](https://ci.appveyor.com/api/projects/status/qimk4dbiattf60e0?svg=true)](https://ci.appveyor.com/project/igeligel/skadisteam-login) |
| skadisteam.inventory | Private - [igeligel/skadisteam.inventory](https://github.com/igeligel/skadisteam.inventory) | WIP | 0.1.0-beta | WIP |

## Packages - Prices
| Package          | Github Repository                                                         | Nuget Package                                                        | Version |  Build Status - Windows |
| ---------------- | ------------------------------------------------------------------------- | -------------------------------------------------------------------- | ------------- | ----------------------- |
| skadiprices.csgofast | [igeligel/skadiprices.csgofast](https://github.com/igeligel/skadiprices.csgofast) | -/- | 0.1.0-beta    | -/- |

## Ship Dates

### skadisteam.login
| Version | Release Date | Changelog |
| ------- | ------------ | --------- |
| 0.1.2-beta | 07/11/16 | [Link](https://github.com/igeligel/skadisteam.login/releases/tag/v0.1.2-beta) |
| 0.1.1-beta | 07/11/16  | [Link](https://github.com/igeligel/skadisteam.login/releases/tag/v0.1.1-beta) |
| 0.1.0-beta | 07/11/16  | [Link](https://github.com/igeligel/skadisteam.login/releases/tag/v0.1.0-beta) |

### skadisteam.inventory (WIP)
| Version | Release Date | Changelog |
| ------- | ------------ | --------- |
| -/- | -/- | -/- |

### skadiprices.csgofast (WIP)
| Version | Release Date | Changelog |
| ------- | ------------ | --------- |
| -/- | -/- | -/- |


## Packages Development - Steam specific

### skadisteam.inventory
- Get inventories of user by public web api access or using partnerinventory
- add price providers dynamically by different packages which will be defined by an interface

### skadisteam.steamid
- A package interacting with steam id's. It should be similar to [this](https://github.com/DoctorMcKay/node-steamid) node.js package.
- It should have a class to instantiate a steam id which can be easily converted to other types. Those types are:
    - steamID (Better name?)
    - steamID3 (Better name?)
    - steamCommunityId (It is basically Steam64Id)

### skadisteam.trade
- A package which should provide trading services like:
    - Getting Trade Offers
    - Accepting/Declining those
    - Sending Trades
    - Confirming Trades (Lookup: [geel9/SteamAuth](https://github.com/geel9/SteamAuth))

### skadisteam.profiles
- Enables the user to comment on user profiles and read out information of the profiles like:
    - Steam Level
    - Comments
    - Games
    - Playtime of games

### skadisteam.groups
- Enables the user to get basic group interaction via the package
- Features should be:
    - Inviting to groups
    - Get group members
    - Post announcements
    - Reply to discussions

### skadisteam.chat
- Enables the user to use the chat interface of steam


## Packages Development - Price provider specific

### skadiprices.steamlytics
- Make api access to [steamlytics.xyz](http://csgo.steamlytics.xyz/) with an api key
- Should be similar to the csgofast package

### skadiprices.steamdata
- Make api access to [steamdata.io](https://steamdata.io/) with an api key
- Should be similar to the csgofast package

## Contributing

For basic support and questions create an issue and ask there.

Otherwise. General contribution works like:
- Create a fork of the project
- add your changes
- submit a pull request

Also be sure to follow these guidelines:
- [C# Code style guide](https://github.com/igeligel/contributing-template/blob/master/code-style/csharp.md)
- [Commit style guide](https://github.com/igeligel/contributing-template/blob/master/commits.md)
