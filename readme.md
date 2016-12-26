# Skadisteam

## Packages - Shared
| Package          | Github Repository                                                            | Nuget Package                                                        | Version |  Build Status - Windows |
| ---------------- | ---------------------------------------------------------------------------- | -------------------------------------------------------------------- | ------------- | ----------------------- |
| skadisteam.shared | [igeligel/skadisteam.shared](https://github.com/igeligel/skadisteam.shared) | WIP | WIP    | WIP |

## Packages - Core
| Package          | Github Repository                                                         | Nuget Package                                                        | Version |  Build Status - Windows |
| ---------------- | ------------------------------------------------------------------------- | -------------------------------------------------------------------- | ------------- | ----------------------- |
| skadisteam.login | [igeligel/skadisteam.login](https://github.com/igeligel/skadisteam.login) | [skadisteam.login](https://www.nuget.org/packages/skadisteam.login/) | 0.1.2-beta    | [![Build status](https://ci.appveyor.com/api/projects/status/qimk4dbiattf60e0?svg=true)](https://ci.appveyor.com/project/igeligel/skadisteam-login) |
| skadisteam.inventory | [igeligel/skadisteam.inventory](https://github.com/igeligel/skadisteam.inventory) | [skadisteam.inventory](https://www.nuget.org/packages/skadisteam.inventory/) | 0.1.0-beta | [![Build status](https://ci.appveyor.com/api/projects/status/ln5ux6vby2ukfaog?svg=true)](https://ci.appveyor.com/project/igeligel/skadisteam-inventory) |
| skadisteam.trade | [igeligel/skadisteam.trade](https://github.com/igeligel/skadisteam.trade) | WIP | WIP | WIP |

## Packages - Prices
| Package          | Github Repository                                                         | Nuget Package                                                        | Version |  Build Status - Windows |
| ---------------- | ------------------------------------------------------------------------- | -------------------------------------------------------------------- | ------------- | ----------------------- |
| skadiprices.csgofast | [igeligel/skadiprices.csgofast](https://github.com/igeligel/skadiprices.csgofast) | [skadiprices.csgofast](https://www.nuget.org/packages/skadiprices.csgofast/) | 0.1.0 | [![Build status](https://ci.appveyor.com/api/projects/status/37o4mjjhds93tgha?svg=true)](https://ci.appveyor.com/project/igeligel/skadiprices-csgofast) |

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
| 0.1.0-beta | 2016-07-26 | [Link](https://github.com/igeligel/skadisteam.inventory/releases/tag/v0.1.0-beta) |

### skadisteam.trade (WIP)
| Version | Release Date | Changelog |
| ------- | ------------ | --------- |
| WIP | WIP | WIP |

### skadiprices.csgofast (WIP)
| Version | Release Date | Changelog |
| ------- | ------------ | --------- |
| 0.1.0 | 2016-07-16 | [Link](https://github.com/igeligel/skadiprices.csgofast/releases/tag/v0.1.0) |
| 0.1.0-beta | 2016-07-16 | [Link](https://github.com/igeligel/skadiprices.csgofast/releases/tag/v0.1.0-beta) |

## Examples
I would be really happy for examples using the api parts. Just create a pull request with the example project and i will add it to the example directory.

Existing Examples:
- WIP

## Packages Development - Steam specific

### skadisteam.inventory
- add price providers dynamically by different packages which will be defined by an interface

### skadisteam.steamid
- A package interacting with steam id's. It should be similar to [this](https://github.com/DoctorMcKay/node-steamid) node.js package.
- It should have a class to instantiate a steam id which can be easily converted to other types. Those types are:
    - steamID (Better name?)
    - steamID3 (Better name?)
    - steamCommunityId (It is basically Steam64Id)

### skadisteam.trade
- A package which should provide trading services like:
    - Declining those
    - Sending Trades

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

### skadiprices.steamapi
- Make api access to [steamapi.io](https://steamapi.io/) with an api key
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
